using Godot;
using System;


public partial class DialogicWrapper : Node {
	Node Dialogic;
        public static bool activeDialogue = false;
	public DialogicWrapper() {}
	public DialogicWrapper(Node parent) {
		 Dialogic = parent.GetNode<Node>("/root/Dialogic");
	}

	public async void Start(string scene) {
		DialogicWrapper.activeDialogue = true;
		Dialogic.Call("start", scene);
		await ToSignal(Dialogic, "timeline_ended");
		DialogicWrapper.activeDialogue = false;
	}

	

}
