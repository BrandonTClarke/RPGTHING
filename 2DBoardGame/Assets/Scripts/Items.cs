using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class Items : MonoBehaviour {

	private List<Item> database = new List<Item>();
	private JsonData itemData;

	void Start()
	{
		itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
		ConstructItemDatabase ();
		//Debug.Log ("Slug is " + database[1].Slug);
		//Debug.Log ("Power is " + database [1].Attack);
		//Debug.Log (FetchItemByID(1).Description);
	}

	public Item FetchItemByID(int id)
	{
		for (int i = 0; i < database.Count; i++) {
			if (database [i].ID == id)
				return database [i];
		}
		return null;
	}

	void ConstructItemDatabase()
	{
		for (int i=0; i<itemData.Count; i++)
		{
			database.Add(new Item( 
				(int)itemData[i]["id"], 
				itemData[i]["title"].ToString(), 
				(int)itemData[i]["value"], 
				(int)itemData[i]["stats"]["dice"], 
				(int)itemData[i]["stats"]["attack"], 
				(int)itemData[i]["stats"]["defense"],
				(int)itemData[i]["stats"]["speed"], 
				(int)itemData[i]["stats"]["health"], 
				itemData[i]["description"].ToString(),
				itemData[i]["slug"].ToString()
			));
		}

	}
}

public class Item
{
	public int ID{ get; set; }
	public string Title{ get; set; }
	public int Value { get; set; }
	public int Dice { get; set; }
	public int Attack { get; set; }
	public int Defense { get; set; }
	public int Speed { get; set; }
	public int Health { get; set; }
	public string Description { get; set;}
	public string Slug { get; set; }
	public Sprite Sprite { get; set; }


	public  Item(int id, string title, int value, int dice, int attack, int defense, int speed, int health, string description, string slug)
	{
		this.ID = id;
		this.Title = title;
		this.Value = value;
			this.Dice = dice;
			this.Attack = attack;
			this.Defense = defense;
			this.Speed = speed;
			this.Health = health;
			this.Description = description;
			this.Slug = slug;
		this.Sprite = Resources.Load<Sprite> ("UI Sprites" + slug);
		
	}

	public Item()
		{
			this.ID = -1;
		}

	}
