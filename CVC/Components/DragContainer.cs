using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVC.Components
{
  public class DragContainer
  {
    public static string efStr = "<div class='row' style='padding:1px;display:flex;padding-left:30px;padding-right:30px;'>" +
                               "<div ondragstart='event.dataTransfer.setData(\"id\", event.target.id)' draggable='true' class='col-xs-12 col-sm-12 col-md-12 col-lg-12' style='background-color: #50c72d; border-radius: 8px;display: flex; justify-content: center;' value='xxId'>" +
                               "xxName" +
                               "</div>" +
                               "</div>";

    public static string GetEF(string machineParameterId, string parameterName){
      return efStr.Replace("xxId", machineParameterId).Replace("xxName", parameterName);
    }

    public static string rowStr = "<div class='row' style='padding:1px;display:flex;'>" +
                               "<div class='col-xs-6 col-sm-6 col-md-6 col-lg-6'>" +
                               "<input type = 'text' value='6 6' style='width:100%;color:black;' readonly/>" +
                               "</div>" +
                               "<div ondragstart='dragGrid(event);' draggable='true' class='col-xs-4 col-sm-4 col-md-4 col-lg-4 dragOrigin' style='background-color: #50c72d; border-radius: 8px;display: flex; justify-content: center;align-items:center;' value='6 6'>" +
                               "drag" +
                               "</div>" +
                               "</div>";
    public static string GetRowStrs(string param)
    {
      if (param != "") 
        return rowStr.Replace("6 6", param);
      else
        return rowStr.Replace("value='6 6'", param).Replace("readonly", param);
    }
    public static string rowCloneStr = "<div class='row' style='padding:1px;display:flex;'>" +
                               "<div class='col-xs-6 col-sm-6 col-md-6 col-lg-6'>" +
                               "<input type = 'text' value='6 6' style='width:100%;color:black;'/>" +
                               "</div>" +
                               "<div ondragstart='dragGrid(event);' draggable='true' class='col-xs-4 col-sm-4 col-md-4 col-lg-4 dragOrigin' style='background-color: #50c72d; border-radius: 8px;padding-left:0px;' value='6 6'>" +
                               "drag" +
                               "</div>" +
                               "</div>";

    public static string GetRowCloneStrs(string param, string id)
    {
      string str = $"<div ondragstart='dragClonedGrid(event);' draggable='true'  class='row workSpace clones rowcontainer' id= {id} value='123450-'>"; ;
      string[] numbers = param.Split(' ');
      foreach (string number in numbers)
      {
        str += $"<div class='col-{number} bg-success' style='height: 100px; border: 1px solid black;'> </div>";
      }
      str += "</div>";
      return str;
    }


    public static string elementStr = "";
    public static string GetElementStrs(string param)
    {
      return elementStr.Replace("6 6", param).Replace("6 6", param);
    }
  }
}

