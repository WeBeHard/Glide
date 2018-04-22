using UnityEngine;
using System;
using System.Collections;



	public class SpawnClass : MonoBehaviour
	{
	public gameObject[] BlockShape;
		public void SpawnClass()
		{
		int i = Random.Range(0, BlockShape.Length);	///Select a random shape defined in ShapeClass
		GameObject temp = Instantiate(BlockShape[i]);
		Managers.Game.currentShape = temp.GetComponent<ShapesClass>();
		temp.transform.parent = Managers.Game.BlockPlaceHolder;
		Managers.Input.isActive = true;
		/////Managers Script needed
		}
	}

