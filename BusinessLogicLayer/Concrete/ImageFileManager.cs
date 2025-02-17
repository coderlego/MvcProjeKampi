﻿using BusinessLogicLayer.Absctract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imageFile;

        public ImageFileManager(IImageFileDal imageFile)
        {
            _imageFile = imageFile;
        }

        public List<ImageFile> GetList()
        {
            return _imageFile.List();

        }
    }
}
