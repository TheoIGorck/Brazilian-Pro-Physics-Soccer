public interface IBoost 
{
    public void Initialize(Ball ball);
    public void Apply();
    public void ResetBoost();

    public bool HasCollided { get; set; }
}
