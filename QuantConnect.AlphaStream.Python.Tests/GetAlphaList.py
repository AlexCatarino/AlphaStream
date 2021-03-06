import unittest
import sys
from test_config import *

sys.path.append('../')

from AlphaStream import AlphaStreamClient

class AlphaIDList(unittest.TestCase):
    def setUp(self):
        config = test_config()
        self.client = AlphaStreamClient(config['testing_client_institution_id'], config['testing_client_token'])

   
    def test_get_alpha_list(self):
        response = self.client.GetAlphaList()
        self.assertIsNotNone(response)
        self.assertGreater(len(response), 250)
        for id in response:
            self.assertIsInstance(id, str)
            self.assertEqual(len(id), 25)

