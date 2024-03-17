
int MissingMax(int map[][max], int k, int find)
{
  if(find >0) {
    for (int i=0, i< max, i++){
      if (map[k][i] == find)
        return MissingMax(map, k, find - 1);
    }
  }
  return find;
}
