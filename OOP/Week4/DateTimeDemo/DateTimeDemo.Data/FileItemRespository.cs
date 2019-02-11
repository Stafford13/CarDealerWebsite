using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DateTimeDemo.Models;
using DateTimeDemo.Tests;

namespace DateTimeDemo.Data
{
    public class FileItemRespository : IItemRepository
    {

        protected List<Item> Items;
        private readonly string FILENAME;

        public FileItemRespository(string filename)
        {
            FILENAME = filename;
            Load();
        }

        private int nextId()
        {
            int id = 0;
            foreach (Item Item in Items)
            {
                if (Item.Id > id)
                {
                    id = Item.Id;
                }
            }
            id = id + 1;
            return id;
        }

        // CREATE
        public Item Create(Item Item)
        {
            Item.Id = nextId();
            Items.Add(Item);
            SaveItems();
            return Item;
        }

        // READALL
        public List<Item> ReadAll()
        {
            return Items;
        }

        // READBY
        public Item ReadById(int id)
        {

            foreach (Item Item in Items)
            {
                if (Item.Id == id)
                {
                    return Item;
                }
            }
            return null;
        }


        public List<Item> ReadByCharacterId(int characterId)
        {
            return this.Items.Where(i => i.CharacterId == characterId).ToList();
        }

        // UPDATE
        public void Update(int id, Item newItemInfo)
        {
            // Loop until find the index, and modify way
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Id != id) continue;
                Items[i] = newItemInfo;
                break;
            }
            SaveItems();
            //int index = _Items.FindIndex((Item c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _Items[index] = newItemInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            Items.RemoveAll((Item ItemInfo) => ItemInfo.Id == id);
            SaveItems();
        }

   

        /// <summary>
        /// Saving to a text file what is in a Item list
        /// </summary>
        private void SaveItems()
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(FILENAME);

                foreach (Item Item in Items)
                {
                    sw.WriteLine(ItemMapper.ToStringCsv(Item));
                    sw.Flush();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                if (sw != null) sw.Close();
            }

        }
        /// <summary>
        /// Load from a text file into the Item list
        /// </summary>

        protected void Load()
        {
            List<Item> results = new List<Item>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(FILENAME);
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    Item c = ItemMapper.ToObject(row);
                    results.Add(c);
                }
                Items = results;

            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.FileName + " was not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }
        
    }
    
}