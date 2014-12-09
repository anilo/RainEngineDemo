#pragma strict

function Start () {

}

function Update () {
	//print ("ok go");

}

function OnTriggerEnter (other : Collider) {
		
	print ("tttrigger enter event");

	if(other.gameObject.tag == "PlayerHead")
	{
		print ("killing collider object");

		Destroy(other.transform.parent.gameObject);
	}
}
