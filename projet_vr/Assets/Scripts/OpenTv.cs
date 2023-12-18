using UnityEngine;

public class OpenTv : MonoBehaviour
{
    public GameObject[] TvOpening;

    public void OpenTvOnClick()
    {
        foreach (var item in TvOpening)
        {
            item.SetActive(true);
        }
    }
}
