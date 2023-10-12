using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
	private Slider slider;
	public Player player;
	public Image filler;

	
	void Awake()
	{
		slider = GetComponent<Slider>();
	}

	void Update()
    {
		if(slider.value <= slider.minValue)
		{
			filler.enabled = false;
		}

		if(slider.value > slider.minValue && !filler.enabled)
		{
			filler.enabled = true;
		}

		float fillVal = player.currentHealth / player.maxHealth;
	
		if (fillVal <= slider.maxValue / 3)
		{
			filler.color = Color.white;

		} else if(fillVal > slider.maxValue /3) {
			filler.color = Color.red;
		}

		slider.value = fillVal;
    }
}
 