using UnityEngine;
using UnityEngine.EventSystems;

public class UnitDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private UnitData unitData;
    private DeckBuildingManager deckBuildingManager;
    private CanvasGroup canvasGroup;
    private Vector3 originalPosition;

    public void Setup(UnitData unitData, DeckBuildingManager manager)
    {
        this.unitData = unitData;
        this.deckBuildingManager = manager;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = transform.position;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("🔹 OnEndDrag appelé pour : " + unitData.Name);

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Lane"))
        {
            Lane lane = hit.collider.GetComponent<Lane>();

            if (lane != null)
            {
                lane.PlaceUnit(unitData);
                deckBuildingManager.RemoveCardFromHand(unitData);
                Destroy(gameObject);
            }
        }
        else
        {
            transform.position = originalPosition;
        }
    }
}
