﻿using System;
using System.IO;
using CommandLine;

namespace VSCodeCppEnvScript.Options
{
    public class CommandOption
    {
        [Option('e', "environmentPath", Required = false, HelpText = "Set the path to install MinGW.")]
        public string EnvironmentPath { get; set; }

        [Option('s', "softwarePath", Required = false, HelpText = "Set the path to install VSCode.")]
        public string SoftwarePath { get; set; }

        [Option('p', "projectPath", Required = false, HelpText = "Set the path of VSCode workspace.")]
        public string ProjectPath { get; set; }
    }
}
