namespace MMH
{
	public class CitizenIdleState : CitizenMovementState
	{
		public CitizenIdleState(Citizen citizen) : base(citizen) { }

		public override void Tick()
		{
			if (_citizen.CanAct())
			{
				_citizen.Cooldown = Utils.RandomRange(4, 16);
				_citizen.Direction = Utils.RandomEnumValue<Direction>();

				_citizen.UpdateRenderDirection();
			}
		}
	}
}
