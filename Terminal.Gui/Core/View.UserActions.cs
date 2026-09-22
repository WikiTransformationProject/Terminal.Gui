using System;

namespace Terminal.Gui {

	// written by LLM, 2026-09-22
	public partial class View {
		public static event Action<View, string, string> UserAction;

		public virtual string UserActionContext => Id?.ToString () ?? string.Empty;

		public void ReportUserAction (string action, string control)
		{
			UserAction?.Invoke (this, action, control);
		}
	}
}
