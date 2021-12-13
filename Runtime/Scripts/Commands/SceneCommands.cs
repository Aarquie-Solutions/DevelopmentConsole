using UnityEngine;
using UnityEngine.SceneManagement;

namespace AarquieSolutions.DevelopmentConsole.Commands
{
	public class SceneCommands
	{
		[DevConsoleMethod( "scene.load", "Loads a scene" ), UnityEngine.Scripting.Preserve]
		public static void LoadScene( string sceneName )
		{
			LoadSceneInternal( sceneName, false, LoadSceneMode.Single );
		}

		[DevConsoleMethod( "scene.load", "Loads a scene" ), UnityEngine.Scripting.Preserve]
		public static void LoadScene( string sceneName, LoadSceneMode mode )
		{
			LoadSceneInternal( sceneName, false, mode );
		}

		[DevConsoleMethod( "scene.loadasync", "Loads a scene asynchronously" ), UnityEngine.Scripting.Preserve]
		public static void LoadSceneAsync( string sceneName )
		{
			LoadSceneInternal( sceneName, true, LoadSceneMode.Single );
		}

		[DevConsoleMethod( "scene.loadasync", "Loads a scene asynchronously" ), UnityEngine.Scripting.Preserve]
		public static void LoadSceneAsync( string sceneName, LoadSceneMode mode )
		{
			LoadSceneInternal( sceneName, true, mode );
		}

		private static void LoadSceneInternal( string sceneName, bool isAsync, LoadSceneMode mode )
		{
			if( SceneManager.GetSceneByName( sceneName ).IsValid() )
			{
				Debug.Log( "Scene " + sceneName + " is already loaded" );
				return;
			}

			if( isAsync )
				SceneManager.LoadSceneAsync( sceneName, mode );
			else
				SceneManager.LoadScene( sceneName, mode );
		}

		[DevConsoleMethod( "scene.unload", "Unloads a scene" ), UnityEngine.Scripting.Preserve]
		public static void UnloadScene( string sceneName )
		{
			SceneManager.UnloadSceneAsync( sceneName );
		}

		[DevConsoleMethod( "scene.restart", "Restarts the active scene" ), UnityEngine.Scripting.Preserve]
		public static void RestartScene()
		{
			SceneManager.LoadScene( SceneManager.GetActiveScene().name, LoadSceneMode.Single );
		}
	}
}