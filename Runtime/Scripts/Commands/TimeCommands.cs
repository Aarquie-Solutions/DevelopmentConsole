using UnityEngine;

namespace AarquieSolutions.DevelopmentConsole.Commands
{
	public class TimeCommands
	{
		[DevConsoleMethod( "time.scale", "Sets the Time.timeScale value" ), UnityEngine.Scripting.Preserve]
		public static void SetTimeScale( float value )
		{
			Time.timeScale = Mathf.Max( value, 0f );
		}

		[DevConsoleMethod( "time.scale", "Returns the current Time.timeScale value" ), UnityEngine.Scripting.Preserve]
		public static float GetTimeScale()
		{
			return Time.timeScale;
		}
	}
}