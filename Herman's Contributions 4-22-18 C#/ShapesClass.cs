using System;
using UnityEngine;
using System.Collections;
using System.Linq;

public enum BlockShape
{
	A,
	B,
	C,
}
	
	public class ShapesClass : MonoBehaviour
	{
	[HideInInspector]
	public ShapeType Variant;
	[HideInInspector]
	public Controller	MoveController;
	void Awake()
		{
		MoveController = GetComponent<Controller> ();
		AssignRandomColor ();
		}
	void Start()
	{
		if(!Managers.Grid.IsValidGridPosition(this.transform))
		{
			Mangers.Game.SetState (typeof(GameOversStateSTANDIN));
			///Requires a GameOverState and GridManager
			Destroy(this.gameObject);
	}
}
////Assign Color method needed? Assuming we're not sticking to one type of block artstyle
