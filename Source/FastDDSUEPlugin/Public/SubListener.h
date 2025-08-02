#pragma once
#include "fastdds/dds/subscriber/DataReaderListener.hpp"



class FASTDDSUEPLUGIN_API SubListener: public eprosima::fastdds::dds::DataReaderListener
{

public:
	SubListener() = default;

	~SubListener() override = default;

	virtual void on_data_available(
		eprosima::fastdds::dds::DataReader* reader) = 0;

	virtual void on_subscription_matched(
		eprosima::fastdds::dds::DataReader* reader,
		const eprosima::fastdds::dds::SubscriptionMatchedStatus& info) override;

	int matched = 0;
	bool isAvailable = true;
	uint32_t samples = 0;
};
