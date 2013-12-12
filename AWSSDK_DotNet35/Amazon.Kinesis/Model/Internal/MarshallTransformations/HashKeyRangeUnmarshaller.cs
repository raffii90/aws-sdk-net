/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.Kinesis.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// HashKeyRangeUnmarshaller
      /// </summary>
      internal class HashKeyRangeUnmarshaller : IUnmarshaller<HashKeyRange, XmlUnmarshallerContext>, IUnmarshaller<HashKeyRange, JsonUnmarshallerContext>
      {
        HashKeyRange IUnmarshaller<HashKeyRange, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public HashKeyRange Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            HashKeyRange hashKeyRange = new HashKeyRange();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StartingHashKey", targetDepth))
              {
                context.Read();
                hashKeyRange.StartingHashKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndingHashKey", targetDepth))
              {
                context.Read();
                hashKeyRange.EndingHashKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return hashKeyRange;
                }
            }
          

            return hashKeyRange;
        }

        private static HashKeyRangeUnmarshaller instance;
        public static HashKeyRangeUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new HashKeyRangeUnmarshaller();
            return instance;
        }
    }
}
  
