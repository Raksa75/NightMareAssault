using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Game/UnitData")]
public class UnitData : ScriptableObject
{
    [SerializeField] private string unitName;
    public string Name => unitName; // Propriété publique pour accéder au nom

    public int health;
    public int attack;
    public int cost;
    public Sprite unitSprite; // Image de l'unité
}
