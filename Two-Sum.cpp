1class Solution {
2public:
3    vector<int> twoSum(vector<int>& nums, int target) {
4        unordered_map<int,int> _map;
5        for(int i=0;i<nums.size();i++)
6        {
7            int diff = target - nums[i];
8            if(_map.count(diff)>0)
9            {
10                vector<int> ans = {_map[diff],i};
11                return ans;
12            }
13            _map[nums[i]] = i;
14        }
15        return {};
16    }
17};