﻿/*
 * Copyright © 2010, Denys Vuika
 * Copyright © 2014, Kastellanos Nikolaos
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.Windows;
namespace tainicom.WpfPropertyGrid
{
  /// <summary>
  /// Provides a unified approach for resolving resources.
  /// </summary>
  public class ResourceLocator
  {
    private readonly Application _application;

    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceLocator"/> class.
    /// </summary>
    public ResourceLocator() : this(Application.Current) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceLocator"/> class.
    /// </summary>
    /// <param name="application">The application instance.</param>
    public ResourceLocator(Application application)
    {
      _application = application;
    }

    /// <summary>
    /// Gets the resource.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <returns>Object from resources.</returns>
    public virtual object GetResource(object key)
    {
      return _application.TryFindResource(key);
    }
  }
}
