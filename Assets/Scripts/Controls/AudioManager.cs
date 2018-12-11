using UnityEngine.Audio;
using UnityEngine;
using System;


public class AudioManager : MonoBehaviour {

	public Sound[] sounds;

	public static AudioManager instance;
	public AudioMixer audioMixer;

	//public AudioMixer mixer;
	void Start()
	{
		try
		{
			Play("ambience");
		}
		catch (System.Exception)
		{
			Debug.Log("ambience missing");
		}
	}
	// Use this for initialization
	void Awake () {
		if(instance == null)
		{
			instance = this;
		}else{
			Destroy(gameObject);
			return;
		}
		DontDestroyOnLoad(gameObject);

		foreach (Sound sound in sounds)
		{
			sound.source = gameObject.AddComponent<AudioSource>();	
			sound.source.clip = sound.clip;
			sound.source.pitch = sound.pitch; 
			sound.source.loop = sound.loop;
		}
	}
	
	public void Play(string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		try
		{
			s.source.Play();
		}
		catch (System.Exception)
		{
			Debug.Log("Sound" + s.name +" Missing");
		}

	}

	public void SetVolume(float vol)
	{
		audioMixer.SetFloat("volume", vol);
		foreach (Sound sound in sounds){
			sound.source.volume = vol;}
		
	}
}
