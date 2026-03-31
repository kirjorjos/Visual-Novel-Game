using Godot;
using System;

public partial class DialogicWrapper : Node {
	Node Dialogic;
	public override void _Ready() {
		 Dialogic = GetNode<Node>("/root/Dialogic");
	}
	// test comment 1

	public void Start(string scene) {
		Dialogic.Call("start", scene);
	}
}
