using UnityEngine;

namespace AarquieSolutions.DevelopmentConsole.Commands
{
	public class PlayerPrefsCommands
	{
		[DevConsoleMethod( "prefs.int", "Returns the value of an Integer PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static string PlayerPrefsGetInt( string key )
		{
			if( !PlayerPrefs.HasKey( key ) ) return "Key Not Found";
			return PlayerPrefs.GetInt( key ).ToString();
		}

		[DevConsoleMethod( "prefs.int", "Sets the value of an Integer PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsSetInt( string key, int value )
		{
			PlayerPrefs.SetInt( key, value );
		}

		[DevConsoleMethod( "prefs.float", "Returns the value of a Float PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static string PlayerPrefsGetFloat( string key )
		{
			if( !PlayerPrefs.HasKey( key ) ) return "Key Not Found";
			return PlayerPrefs.GetFloat( key ).ToString();
		}

		[DevConsoleMethod( "prefs.float", "Sets the value of a Float PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsSetFloat( string key, float value )
		{
			PlayerPrefs.SetFloat( key, value );
		}

		[DevConsoleMethod( "prefs.string", "Returns the value of a String PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static string PlayerPrefsGetString( string key )
		{
			if( !PlayerPrefs.HasKey( key ) ) return "Key Not Found";
			return PlayerPrefs.GetString( key );
		}

		[DevConsoleMethod( "prefs.string", "Sets the value of a String PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsSetString( string key, string value )
		{
			PlayerPrefs.SetString( key, value );
		}

		[DevConsoleMethod( "prefs.delete", "Deletes a PlayerPrefs field" ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsDelete( string key )
		{
			PlayerPrefs.DeleteKey( key );
		}

		[DevConsoleMethod( "prefs.clear", "Deletes all PlayerPrefs fields" ), UnityEngine.Scripting.Preserve]
		public static void PlayerPrefsClear()
		{
			PlayerPrefs.DeleteAll();
		}
	}
}