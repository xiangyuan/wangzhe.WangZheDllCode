using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Soldier_BTSoldierSiege_node516 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			ObjBehaviMode curBehavior = ((ObjAgent)pAgent).GetCurBehavior();
			ObjBehaviMode objBehaviMode = ObjBehaviMode.State_OutOfControl;
			return (curBehavior == objBehaviMode) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
