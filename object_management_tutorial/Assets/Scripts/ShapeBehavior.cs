using UnityEngine;

public abstract class ShapeBehavior

#if UNITY_EDITOR   // we need to extend ScriptableObject to survive hot reload in editor
    : ScriptableObject
#endif

{
#if UNITY_EDITOR
    public bool IsReclaimed { get; set; }

    private void OnEnable()
    {
        if (IsReclaimed)
            Recycle();
    }
#endif
    public abstract void GameUpdate(Shape shape);

    public abstract void Save(GameDataWriter writer);

    public abstract void Load(GameDataReader reader);

    public abstract ShapeBehaviorType BehaviorType { get; }

    public abstract void Recycle();

}
