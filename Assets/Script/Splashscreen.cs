using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Splashscreen : MonoBehaviour
{
    // Start is called before the first frame update
    public string halamanSelanjutnya;
    public int waktuTunggu;
    void Awake()
    {
        DontDestroyOnLoad(this);
    }


    private void Start()
    {
        StartCoroutine(PindahHalaman());
    }

    IEnumerator PindahHalaman()
    {
        yield return new WaitForSeconds(waktuTunggu);
        SceneManager.LoadScene(halamanSelanjutnya);
    }
}
