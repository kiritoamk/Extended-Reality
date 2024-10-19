using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KIBAR : MonoBehaviour
{
	public Slider slider;
	public Gradient gradient;
	public Image kFill;

	public void SetMaxKi(int Ki)
	{
		slider.maxValue = Ki;
		slider.value = Ki;

		kFill.color = gradient.Evaluate(1f);
	}

	public void SetKi(int Ki)
	{
		slider.value = Ki;

		kFill.color = gradient.Evaluate(slider.normalizedValue);
	}


}
