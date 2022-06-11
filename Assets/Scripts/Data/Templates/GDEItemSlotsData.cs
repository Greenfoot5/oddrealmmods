using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemSlots")]
public class GDEItemSlotsData : ScriptableObject
{
	public string Key { get { return name; } }
	public string FriendlyName = "";
	public string EmptyIcon = "";
	public int InventoryType = 0;
}
