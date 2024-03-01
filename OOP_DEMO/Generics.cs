using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DEMO;
public class Generics<T> where T : IEntity
{

    List<T> entities = new List<T>();


    public Generics()
    {
        entities = new List<T>();
    }

    


    public void SaveChanges()
    {
        //save logic
    }

    public void Create(T entity) 
    {
        entity.Status = "Open";
        entity.Id = Guid.NewGuid().ToString();
        entities.Add(entity);
        SaveChanges();


    }
    public void Edit(T entity)
    {
        entity.Status = "Edited";
        SaveChanges();
    }

    public void Delete(string id)
    {
        T currentEntity;
        currentEntity = entities.Where(z => z.Id == id).FirstOrDefault();
        entities.Remove(currentEntity);
        SaveChanges();


    }

    public List<T> Read()
    {

        return entities;


    }
}



























public interface IEntity
{
    public string Id { get; set; }
    public string CompanyName { get; set; }
    public string Status { get; set; }

    void SetStatus(string status);
    void SetStatus(string status, string message);


}



public class RequestForPayment : IEntity
{
    public string Id { get;set; }
    public string CompanyName { get;set; }
    public string Status { get;set; }

    public string RapsReference { get; set; }

    public void SetStatus(string status)
    {
        throw new NotImplementedException();
    }

    public void SetStatus(string status, string message)
    {
        throw new NotImplementedException();
    }
}


public class Invoice : IEntity
{
    public string Id { get;set; }
    public string CompanyName { get;set; }
    public string Status { get;set; }

    public string InvoiceReference { get; set; }

    public void SetStatus(string status)
    {
        throw new NotImplementedException();
    }

    public void SetStatus(string status, string message)
    {
        throw new NotImplementedException();
    }
}