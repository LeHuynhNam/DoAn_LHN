package com.example.shopquanao.adapter;


import android.content.Context;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.shopquanao.R;
import com.example.shopquanao.model.Sanpham;
import com.squareup.picasso.Picasso;

import java.text.DecimalFormat;
import java.util.ArrayList;

public class QuanaoAdapter extends BaseAdapter {
    Context context;
    ArrayList<Sanpham>arrayquanao;

    public QuanaoAdapter(Context context, ArrayList<Sanpham> arrayquanao) {
        this.context = context;
        this.arrayquanao = arrayquanao;
    }

    @Override
    public int getCount() {
        return arrayquanao.size();
    }

    @Override
    public Object getItem(int i) {
        return arrayquanao.get(i);
    }

    @Override
    public long getItemId(int i) {
        return i;
    }
    public class ViewHolder
    {
        public TextView txttenquanao,txtgiaquanao,txtmotaquanao;
        public ImageView imgquanao;

    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        ViewHolder viewHolder=null;
        if(view==null)
        {
            viewHolder=new ViewHolder();
            LayoutInflater inflater= (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view =inflater.inflate(R.layout.dong_quanao,null);
            viewHolder.txttenquanao=view.findViewById(R.id.textviewquanao);
            viewHolder.txtgiaquanao=view.findViewById(R.id.textviewgiaquanao);
            viewHolder.txtmotaquanao=view.findViewById(R.id.textviewmotaquanao);
            viewHolder.imgquanao=view.findViewById(R.id.imageviewquanao);

            view.setTag(viewHolder);
        }
        else
        {
            viewHolder= (ViewHolder) view.getTag ();
        }
        Sanpham sanpham= (Sanpham) getItem(i);
        viewHolder.txttenquanao.setText(sanpham.getTensanpham());
        DecimalFormat decimalFormat=new DecimalFormat("###,###,###");//3 con s??? chuy???n v??? 1 d???u ph???y
        viewHolder.txtgiaquanao.setText("Gi??:"+decimalFormat.format(sanpham.getGiasanpham()) +"??");
        viewHolder.txtmotaquanao.setMaxLines(2);//set m?? t??? qu???n ??o th??nh 2 d??ng
        viewHolder.txtmotaquanao.setEllipsize(TextUtils.TruncateAt.END);//n???u m?? t??? qu?? d??i th?? hi???n d???u 3 ch???m
        viewHolder.txtmotaquanao.setText(sanpham.getMotasanpham());
        Picasso.get().load(sanpham.getHinhanhsanpham())
                .placeholder(R.drawable.noimage)
                .error(R.drawable.error)
                .into(viewHolder.imgquanao);
        return view;
    }
}
