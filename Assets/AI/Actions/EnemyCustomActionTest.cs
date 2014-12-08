using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Core;
using RAIN.Action;

[RAINAction]
public class EnemyCustomActionTest : RAINAction
{
    public override void Start(AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(AI ai)
    {
	//	if(ai.WorkingMemory.GetItem<int>("enemyHealth") <= 0)
	//	{
			MonoBehaviour.Destroy(ai.Body);
	//	}

        return ActionResult.SUCCESS;
    }

    public override void Stop(AI ai)
    {
        base.Stop(ai);
    }
}