using Godot;
using System;


public partial class DialogicWrapper : Node {
	Node Dialogic;
	public DialogicWrapper(Node parent) {
		 Dialogic = parent.GetNode<Node>("/root/Dialogic");
	}

	public void Start(string scene) {
		Dialogic.Call("start", scene);
	}
}
