using Godot;
using System;

public partial class TreasureChest : Area2D
{
    private void OnBodyEntered(Node body)
    {
        if (body is CharacterBody2D)
        {
            // Get the ScoreManager from the scene
            var scoreManager = GetNode<ScoreManager>("/root/Node2D/CanvasLayer");
            scoreManager.IncrementScore(10);

            // Optionally, you can queue_free the chest to remove it from the scene
            QueueFree();
        }
    }
}

