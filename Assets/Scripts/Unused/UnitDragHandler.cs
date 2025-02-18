using UnityEngine;
using UnityEngine.EventSystems;

public class UnitDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Unit unit;
    private DeckBuildingManager deckBuildingManager;
    private CanvasGroup canvasGroup;

    public void Setup(Unit unit, DeckBuildingManager manager)
    {
        this.unit = unit;
        this.deckBuildingManager = manager;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (eventData.pointerEnter != null && eventData.pointerEnter.transform == deckBuildingManager.deckContainer)
        {
            deckBuildingManager.AddUnitToDeck(unit);
            Destroy(gameObject); // Supprime l'unité de la collection après l'ajout au deck
        }
    }
}
