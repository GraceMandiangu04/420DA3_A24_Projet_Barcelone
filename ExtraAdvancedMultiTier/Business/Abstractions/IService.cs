﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IService : IStartable, IStoppable {

    public IServiceContainer? GetParent();

    public T? GetParent<T>() where T : class, IServiceContainer;

}
