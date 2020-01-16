using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Duck : MonoBehaviour
{
    public int speed = 4;
    private SpriteRenderer sr;
    public Animator animator;
    public AudioClip audioduck;
    public AudioClip audioshot;
    public AudioSource source;

    public bool clicked = false;

    public float x;
    public float y;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (clicked == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.down * speed * 2 * Time.deltaTime;
        }

        x = transform.position.x;
        y = transform.position.y;

        if (x <= -18) { Destroy(gameObject); }
        if (y <= -6) { Destroy(gameObject); }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.PlayOneShot(audioshot);
        }
    }

    public IEnumerator OnMouseDown()
    {
        if (clicked == false)
        {
            source.PlayOneShot(audioduck);
            clicked = true;
            yield return new WaitForSeconds(0.01f);
            animator.SetBool("falling", true);
        }
    }
}