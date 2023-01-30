namespace AsterNET.NetStandard.Manager.Event
{
	/// <summary>
	/// A ReconnectEvent is triggered when the connection to the asterisk server attempted.<br/>
	/// It is a pseudo event not directly related to an asterisk generated event.
	/// </summary>
	public class ReconnectEvent : ConnectionStateEvent
	{
		public ReconnectEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}