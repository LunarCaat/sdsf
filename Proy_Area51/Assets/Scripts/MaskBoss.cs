using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskBoss : Enemy {
    public Transform startTransform;
    private Vector3 startPosition;
	// Use this for initialization
	protected override void Start () {
        base.Start();
        startPosition = startTransform.position;
	}
	private void Update()
	{
        if(transform.position!=startPosition)
        transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime);
	}

}
