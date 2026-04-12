using Godot;
using System;

public partial class TitleScreen : Control {

	public void OnPlayButtonPress() {
		GetTree().ChangeSceneToFile("MainLevel.tscn");
	}

	public void OnQuitButtonPress() {
		GetTree().Quit();
	}
}
