using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using bP.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Data.Repositories
{
    public class UploadFileRepository : IUploadFileRepository
    {
        public readonly AppDBContext _context;
        public UploadFileRepository(AppDBContext context)
        {
            _context = context;
        }
        public Task<UploadFile> Add(UploadFile model)
        {
            return Task.Run(async () =>
            {
                _context.UploadFiles.Add(model);
                _context.SaveChangesAsync();
                return await _context.UploadFiles.FindAsync(model);
            });
        }

        public Task Cancel(string Key)
        {
            throw new NotImplementedException();
        }

        public Task Close(string key)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string key)
        {
            return Task.Run(async () =>
            {
                var file = await _context.UploadFiles.FindAsync(key);
                _context.UploadFiles.Remove(file);
                return await _context.UploadFiles.ToListAsync();
            });
        }

        public Task<UploadFile> Get(string Key)
        {
            return Task.Run(async () =>
            {
                var file = await _context.UploadFiles.FindAsync(Key);
                if (file == null)
                {
                    return null;
                }
                else
                {
                    return file;
                }
            });
        }

        public Task<UploadFile> Get(UploadFile model)
        {
            return Task.Run(async () =>
            {
                var file = await _context.UploadFiles.FindAsync(model);
                if (file == null)
                {
                    return null;
                }
                else
                {
                    return file;
                }
            });
        }

        public Task<List<UploadFile>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.UploadFiles.ToListAsync();
            });
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(UploadFile model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<UploadFile> UpdatePut(UploadFile model)
        {
            throw new NotImplementedException();
        }
    }
}
