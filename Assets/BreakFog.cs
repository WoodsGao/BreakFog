using UnityEngine;

[ExecuteInEditMode]
public class BreakFog : MonoBehaviour
{
    public float Range = 0;
    public int Index = 0;
    private int _propId;

    void OnEnable()
    {
        _propId = Shader.PropertyToID("_BreakFogPosition" + Index);
    }

    void OnDisable()
    {
        Shader.SetGlobalVector(_propId, Vector4.zero);
    }

    void Update()
    {
        Shader.SetGlobalVector(_propId, new Vector4(transform.position.x, transform.position.y, transform.position.z, Range));
    }
}
