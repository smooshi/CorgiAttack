﻿using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;
using System.Collections;

public class TopTenHandler : MonoBehaviour {
	private string topTenXMLfilepath = "topTenStorage.xml";
	private Ranking rank;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public List<Ranking> GetTopTen() {
		var Stats = StatCollector.Load(Path.Combine(Application.dataPath, topTenXMLfilepath));
		/*
		for (int i=0; i < Stats.TopTen.Length; i++) {
			rank = Stats.TopTen[i];
			Debug.Log (rank.name + " "+ rank.rank + " "+ rank.score);
		}*/

		List<Ranking> TopTen = new List<Ranking> ();
		foreach (Ranking r in Stats.TopTen) {
			TopTen.Add (r);
		}
			
		return TopTen;
	}

	public void StoreTopTen(List<Ranking> TopTen) {
		StatCollector collector = new StatCollector ();
		collector.SetTopTen (TopTen);
		collector.Save(Path.Combine(Application.dataPath, topTenXMLfilepath));
		Debug.Log ("Saving TopTen...");
	}
}
