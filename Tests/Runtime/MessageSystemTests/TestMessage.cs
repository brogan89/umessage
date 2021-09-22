﻿using System.Collections.Generic;
using UnityEngine;

namespace UMessageSystem.Tests
{
	public class TestMessage : IMessage
	{
		public string Name;
		public int Level;
		public Vector2 Position;
		public Vector2[] WayPoints;
		public List<int> Numbers;

		public override string ToString()
		{
			return JsonUtility.ToJson(this, true);
		}
		
		public static TestMessage NewMessage()
		{
			var message = new TestMessage
			{
				Name = "Player 1",
				Level = 69,
				Position = new Vector2(0.69f, 4.20f),
				WayPoints = new Vector2[3],
				Numbers = new List<int>()
			};

			// generate random numbers
			for (int i = 0; i < message.WayPoints.Length; i++)
			{
				message.WayPoints[i] = new Vector2(Random.value, Random.value);
				message.Numbers.Add(Mathf.RoundToInt(Random.value * 100));
			}

			return message;
		}
	}
}