using Godot;
using System;

public partial class Player : CharacterBody2D {
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	public AnimatedSprite2D animation;

	DialogicWrapper dialogic;

	public override void _Ready() {
		animation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		dialogic = new DialogicWrapper(this);
	}

	public override void _PhysicsProcess(double delta) {
		Vector2 velocity = Velocity;

		if (velocity.X > 1 || velocity.X < -1) {
			animation.Animation = "walk";
			animation.FlipH = (velocity.X < 0);
		} else animation.Animation = "idle";

		// Add the gravity.
		if (!IsOnFloor()) {
			velocity += GetGravity() * (float)delta;
		}

		// Handle Jump.
		if (Input.IsActionJustPressed("up") && IsOnFloor()) {
			velocity.Y = JumpVelocity;
			animation.Animation = "jump";
		}

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		if (direction != Vector2.Zero) {
			velocity.X = direction.X * Speed;
		} else {
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}

	public void _on_goose_1_body_entered(Node2D body) {
		dialogic.Start("goose1");
	}

	public void _on_goose_2_body_entered(Node2D body) {
		dialogic.Start("goose2");
	}

	public void _on_goose_3_body_entered(Node2D body) {
		dialogic.Start("goose3");
	}

	public void _on_goose_4_body_entered(Node2D body) {
		dialogic.Start("goose4");
	}

	public void _on_goose_5_body_entered(Node2D body) {
		dialogic.Start("goose5");
	}

	public void _on_goose_6_body_entered(Node2D body) {
		dialogic.Start("goose6");
	}
}
