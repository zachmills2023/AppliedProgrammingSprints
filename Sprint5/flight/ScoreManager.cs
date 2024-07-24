using Godot;
using System;

public partial class ScoreManager : CanvasLayer
{
    private int score = 0;
    private Label scoreLabel;

    public override void _Ready()
    {
        // Get the Label node
        scoreLabel = GetNode<Label>("Label");
        UpdateScoreLabel();
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        UpdateScoreLabel();
    }

    private void UpdateScoreLabel()
    {
        GD.Print("Score: " + score);  // Debug print
        scoreLabel.Text = "Score: " + score.ToString();
    }
}
