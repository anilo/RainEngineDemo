#pragma strict

function Start () {

}

function Update () {
	print ("ok go");

}

function OnTriggerEnter (other : Collider) {
		
	print ("trying to jump");

	if(other.gameObject.tag == "PlayerHead")
	{
		Destroy(other.gameObject);
	}
}