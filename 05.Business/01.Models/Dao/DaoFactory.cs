using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper;
using System.Xml;
using IBatisNet.Common.Utilities;
using System;


namespace _05.Business._01.Models.Dao
{
	public class DaoFactory
	{
    public static ISqlMapper EntityMapper
    {
      get
      {
        try
        {
          ISqlMapper mapper = Mapper.Instance();
          return mapper;
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
    }
  }

  
}
