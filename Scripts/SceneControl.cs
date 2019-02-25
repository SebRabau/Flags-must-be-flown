using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public AudioClip click;
    private AudioSource audioSource;
    private IEnumerator waiter;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        waiter = wait();
    }

    public void PlayGame()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("Game");        
    }

    public void Menu()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("Menu");
    }

    public void CharSelect()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("CharSelect");
    }

    public void Introduction()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("Introduction");
    }

    public void Settings()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("Settings");
    }

    public void AboutUs()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("AboutUs");
    }

    public void Pride()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("Pride");
    }

    public void Controller()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        SceneManager.LoadScene("Controllers");
    }

    public void QuitGame()
    {
        audioSource.PlayOneShot(click);
        StartCoroutine(waiter);
        Debug.Log("Quit !");
        Application.Quit();
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(click.length);
    }
}