﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
	public enum Rarity
	{
		N, R, SR, SSR, SSSR, SSSSR
	}

	//public int gachaCount;

	void Start ()
	{	
	}
	
	void Update ()
	{	
	}

	Rarity Dancha()
	{
		int randomNumber = Random.Range(1, 10000000);
		//Debug.Log(randomNumber);

		if(randomNumber > 2500000)
		{
			return Rarity.N;
		}
		else if(randomNumber > 1000000)
		{
			return Rarity.R;
		}
		else if(randomNumber > 100201)
		{
			return Rarity.SR;
		}
		else if(randomNumber > 201)
		{
			return Rarity.SSR;
		}
		else if(randomNumber > 1)
		{
			return Rarity.SSSR;
		}
		else
		{
			return Rarity.SSSSR;			
		}
	}

	public void PlayGacha(int count)
	{
		int[] GachaResult = new int[6] {0, 0, 0, 0, 0, 0};

		for (int i = 0; i < count; i++)
		{
			int a = (int)Dancha();

			GachaResult[a] = GachaResult[a] + 1;
		}

		Debug.Log(GachaResult[0] + ", "
				+ GachaResult[1] + ", "
				+ GachaResult[2] + ", "
				+ GachaResult[3] + ", "
				+ GachaResult[4] + ", "
				+ GachaResult[5]);

		//Debug.Log(gameObject.GetComponentInParent<ShowGachaResult>());
		gameObject.GetComponentInParent<ShowGachaResult>().UpdateResult(GachaResult);
	}
}
