using UnityEngine;

[RequireComponent(typeof(NumberField))]
public class ScoreSyncFromGlobal : MonoBehaviour
{
    private NumberField nf;

    private void Awake()
    {
        nf = GetComponent<NumberField>();
    }

    private void Update()
    {
        nf.SetNumber(GlobalScore.Value);
    }
}
