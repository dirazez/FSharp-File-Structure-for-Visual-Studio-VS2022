﻿#I "bin/Debug/net48"
#r "FSharp.Compiler.Service.dll"
#r "FSharpFileAst.dll"

open System.IO
open FSharpFileAst
open FSharp.Compiler
open FSharp.Compiler.Text
open FSharpFileAst.TreeModel

fsi.AddPrinter(fun (r:range) -> sprintf "R(%d,%d-%d,%d)" r.StartLine r.StartColumn r.EndLine r.EndColumn)

let filename = "m:/lab.fsx"
let text = File.ReadAllText(filename)
let an = TreeModel.getModel(filename, text)

an

//an.Caption
//an.Range
//an.Children.[0].Children.[0].Children.[1].Caption
