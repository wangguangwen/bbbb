using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public interface IAAA1
    {
        string DDD { get; set; }

        string bbb();
        string GetData();
    }

public class WorkFlowNode
{
   
     public int NodeID { get; set; }
    public string NodeName { get; set; }

    public List<Guid> TaskUsers { get; set; }

    public string FormURL { get; set; }
    
    /// <summary>
    /// 1:开始节点，2：判断节点，3：审批节点，4：结束节点
    /// </summary>
    public int NodeTypeID { get; set; }

    public List<WorkFlowNode> To { get; set; }

    public List<WorkFlowNode> From { get; set; }


}
}