using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GroundManager : MonoBehaviour {

	public Transform prefab;
	public int numOfObjs;
	public float recycleOffset;
	public Vector3 startPos;
	public Vector3 minSize, maxSize;

	private Vector3 nextPos;
	private Queue<Transform> objectQueue;
	// Use this for initialization
	void Start () {
		objectQueue = new Queue<Transform>(numOfObjs);
		for (int i = 0; i < numOfObjs; i++) {
			objectQueue.Enqueue ((Transform)Instantiate (prefab));
		}
		nextPos = startPos;
		for (int i = 0; i < numOfObjs; i++) {
			Recycle ();
		}
	}

	// Update is called once per frame
	void Update () {
		if (objectQueue.Peek().localPosition.x + recycleOffset < PlayerController.distTraveled){
			Recycle ();
		}
	}

	private void Recycle() {
		Vector3 scale = new Vector3 (
			Mathf.Floor(Random.Range(minSize.x, maxSize.x)),
			Mathf.Floor(Random.Range(minSize.y, maxSize.y)),
			Random.Range(minSize.z, maxSize.z)
		);

		Vector3 pos = nextPos;
		pos.x += scale.x * 0.5f;

		pos.y += scale.y * 0.5f;


		Transform o = objectQueue.Dequeue ();
		o.localScale = scale;
		o.localPosition = pos;
		nextPos.x += scale.x;
		objectQueue.Enqueue(o);
	}

}

