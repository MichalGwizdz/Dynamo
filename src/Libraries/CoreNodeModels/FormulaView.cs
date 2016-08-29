using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using DSCore;
using CoreNodeModels.Properties;
using ProtoCore.AST.AssociativeAST;
using ProtoCore.Mirror;
using System.Globalization;

using Dynamo.Engine;
using Dynamo.Graph.Nodes;
using DynamoConversions;

public static class Utl
{
  public static string returnString(string inputString)
  {
    return inputString;
  }
}

namespace CoreNodeModels
{
    [IsDesignScriptCompatible]
    [NodeName("MathJax Formula View")]
    [NodeCategory("Core.View.Create")]
    [NodeDescription("Test MathJax")]
    [NodeSearchTags("MathJax")]

    [InPortNames("formulaIn")]
    [InPortTypes("string")]
    [InPortDescriptions("MathJax string")]
    [OutPortNames("formulaOut")]
    [OutPortTypes("string")]
    [OutPortDescriptions("MathJax string")]

    public class FormulaView : NodeModel
    {
        private string formula = "$$ax^2+bx+c=0$$";
        public string Formula
        {
          get{ return formula; }
          set{
            formula = value;
            RaisePropertyChanged("Formula");
            OnNodeModified(false);
          }
        }
        public string GetFormula()
        {
          return Formula;
        }
        public FormulaView()
        {
            RegisterAllPorts();
        }
   /* public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
    {
      if (!HasConnectedInput(0))
      {
        return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
      }
      //          Func<string> GetFormula =()=> formula; 
      //var node = AstFactory.BuildFunctionCall(new Func<string, string>(Utl.returnString), inputAstNodes);
      //var node = AstFactory.BuildFunctionCall("FormulaView", "GetFormula", inputAstNodes);
      //var node = AstFactory.BuildFunctionCall(GetFormula, inputAstNodes);

      var node = AstFactory.BuildFunctionCall(
                  new Func<string, string>(Conversions.retArg), inputAstNodes);
      var assignment = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), node);
          return new[] { assignment };
      }*/
    }
}
