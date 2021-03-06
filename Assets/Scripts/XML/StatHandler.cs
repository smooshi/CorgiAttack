﻿using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;
using System.Collections;

public class StatHandler : MonoBehaviour {
	private string playerStatsXMLfilepath = "playerStatStorage.xml";

	private Player stat;
	private StatCollector collector;

	void Awake() {
		collector = new StatCollector ();
	}
	// Use this for initialization
	void Start () {
		collector = new StatCollector ();
		/*
		var Stats = StatCollector.Load(Path.Combine(Application.dataPath, playerStatsXMLfilepath));

		Debug.Log ("Loop through player events");
		for (int i=0; i < Stats.Players.Length; i++) {
			stat = Stats.Players [i];
			Debug.Log (stat.playerName);
			Debug.Log (stat.totalRounds);
			Debug.Log (stat.totalPoints);
			Debug.Log (stat.highScore);
		}*/
	}

	public Player GetStats() {
		var Stats = StatCollector.Load(Path.Combine(Application.dataPath, playerStatsXMLfilepath));
		stat = Stats.Players [0]; //pelaajia on vain yksi
		collector.SetPlayers(Stats.Players);
		return stat;
	}

	public void SaveStats(Player p) {
		//StatCollector collector = new StatCollector ();
		collector.SetPlayer (p);
		collector.Save(Path.Combine(Application.dataPath, playerStatsXMLfilepath));
		Debug.Log ("Saving Stats?");
	}
}
