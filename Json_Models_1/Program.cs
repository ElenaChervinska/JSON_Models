﻿using Newtonsoft.Json;
using System.IO;
using System;

// The first case deserialization/serialization

string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;

var jsonContent = File.ReadAllText($"{projectDirectory}/start.json");

var books = JsonConvert.DeserializeObject<Book[]>(jsonContent);

var serializedBooks = JsonConvert.SerializeObject(books, Formatting.Indented);

Console.WriteLine(serializedBooks);