﻿using _09_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00.Components
{
    abstract class Component
    {
        /// <summary>
        /// The GameObject that this component is attached to
        /// </summary>
        public GameObject GameObject { get; set; }

        /// <summary>
        /// The Awake method, is called once per component
        /// </summary>
        public void Awake()
        { 
        
        }

        /// <summary>
        /// Start is called after awake and is only called once
        /// </summary>
        public void Start()
        { 
        }

        /// <summary>
        /// Runs every frame as along as t he component is enabled
        /// </summary>
        public void Update()
        {

        }
    }
}
