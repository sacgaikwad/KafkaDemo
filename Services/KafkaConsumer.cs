using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KafkaDemo.Services
{
    public class KafkaConsumer
    {
        private string _topicName;
        private ConsumerConfig _consumerConfig;
        private IConsumer<string, string> _consumer;
        private static readonly Random rand = new Random();

        public KafkaConsumer(ConsumerConfig config, string topicName)
        {
            this._topicName = topicName;
            this._consumerConfig = config;            
            this._consumer.Subscribe(topicName);
        }
    }
}
