using Godot;
using System;

using Godot;

public partial class Player : CharacterBody2D
{
  [Export]
  public float Speed = 300.0f;

  public override void _PhysicsProcess(double delta)
  {
    // Get input direction
    Vector2 velocity = Vector2.Zero;

    // WASD movement
    if (Input.IsKeyPressed(Key.W))
    {
      velocity.Y -= 1;
    }
    if (Input.IsKeyPressed(Key.S))
    {
      velocity.Y += 1;
    }
    if (Input.IsKeyPressed(Key.A))
    {
      velocity.X -= 1;
    }
    if (Input.IsKeyPressed(Key.D))
    {
      velocity.X += 1;
    }

    // Normalize velocity to prevent faster diagonal movement
    if (velocity.Length() > 0)
    {
      velocity = velocity.Normalized() * Speed;
    }

    // Apply movement
    Velocity = velocity;
    MoveAndSlide();
  }
}
